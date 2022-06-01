using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.ViewModels
{    public class HomeViewModel
    {
        public string Text { get; set; }
        public List<LaborViewModel> Labors { get; set; }
        public HomeViewModel()
        {
            Labors = new List<LaborViewModel>();

            Labors.Add(new LaborViewModel() { Id = 0, Title = "Calculator", Text = "Написать программу, принимающую два целых(int) числа в качестве агрументов и возвращающую их сумму." });
            Labors.Add(new LaborViewModel() { Id = 1, Title = "Hello World", Text = "Написать программу, вовращающую строку \"Hello World!\"." });

            /*Text = "using System;" +
                "class Program {" +
                "static void Main() {" +
                "Console.WriteLine(\"HelloWorld!\");" +
                "Console.ReadKey();" +
                "}" +
                "}";*/
        }
    }
}
