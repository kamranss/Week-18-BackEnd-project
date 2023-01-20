// See https://aka.ms/new-console-template for more information
using HRApp.Controller;
using Utilities.Helpers;

EmployeeController employeeController = new EmployeeController();
bool whileresult = true;

while (whileresult)
{
    Helper.consolemessage(ConsoleColor.DarkYellow, ConsoleMessages.Options);
    string menuoption = Console.ReadLine();
    int selectedbutton;
    bool selection = int.TryParse(menuoption, out selectedbutton);

    if (selectedbutton>0 && selectedbutton <10)
    {
        switch (selectedbutton)
        {
            case (int)Helper.Buttons.CreateEmployee:
                employeeController.CreateEmployee();
                break;

            default:
                break;
        }
    }
    else
    {
        Helper.consolemessage(ConsoleColor.DarkGreen, "Choose correct option");
    }
}