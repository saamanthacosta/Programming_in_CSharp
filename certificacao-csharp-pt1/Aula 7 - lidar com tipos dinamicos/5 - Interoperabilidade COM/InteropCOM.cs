﻿using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace certificacao_csharp_roteiro
{
    class InteropCOM : IAulaItem
    {
        public void Executar()
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);
            dynamic excel = Activator.CreateInstance(excelType);

            excel.Visible = true;
            excel.Workbooks.Add();

            dynamic planilha = excel.ActiveSheet;

            planilha.Cells[1, "A"] = "Alura";
            planilha.Cells[1, "B"] = "Cursos";
            planilha.Cells[2, "A"] = "Certificação";
            planilha.Cells[2, "B"] = "C#";
            planilha.Columns[1].AutoFit();
            planilha.Columns[2].AutoFit();
        }
    }
}
