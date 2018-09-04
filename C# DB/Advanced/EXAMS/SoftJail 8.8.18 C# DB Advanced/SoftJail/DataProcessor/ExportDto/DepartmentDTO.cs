using SoftJail.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftJail.DataProcessor.ExportDto
{
    public class DepartmentDTO
    {
        public string Name { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
