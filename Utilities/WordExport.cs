using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;

namespace Utilities
{
    public class WordExport
    {
        private Application _app;
        public Document _doc;
        private object _pathFile;

        public WordExport(string vPath, bool vCreateApp)
        {
            _pathFile = vPath;
            _app = new Application();
            _app.Visible = vCreateApp;
            object ob = System.Reflection.Missing.Value;
            _doc = _app.Documents.Add(ref _pathFile, ref ob, ref ob, ref ob);
        }

        public void WriteFields(Dictionary<string, string> vValues)
        {
            if (_doc.Fields.Count == 0)
            {
                throw new InvalidOperationException("No fields found in the document.");
            }
            foreach (Field field in _doc.Fields)
            {
                string fieldName = field.Code.Text.Substring(11, field.Code.Text.IndexOf("\\") - 12).Trim();
                if (vValues.ContainsKey(fieldName))
                {
                    field.Select();
                    _app.Selection.TypeText(vValues[fieldName]);
                }
            }
        }

        public void WriteTable(System.Data.DataTable vDataTable, int vIndexTable)
        {
            Table tbl = _doc.Tables[vIndexTable];
            int lenrow = vDataTable.Rows.Count;
            int lencol = vDataTable.Columns.Count;
            for (int i = 0; i < lenrow; ++i)
            {
                object ob = System.Reflection.Missing.Value;
                tbl.Rows.Add(ref ob);
                for (int j = 0; j < lencol; ++j)
                {
                    tbl.Cell(i + 2, j + 1).Range.Text = vDataTable.Rows[i][j].ToString();
                }
            }
        }

        public void Close()
        {
            _doc.Close();
            _app.Quit();
        }
    }
}