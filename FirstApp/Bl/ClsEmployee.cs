using FirstApp.Models;

namespace FirstApp.Bl
{
    public class ClsEmployee
    {
        public LinkedList<EmployeesModel> GetData()
        {
            var ListEmployees = new LinkedList<EmployeesModel>();
            //

            EmployeesModel model = new EmployeesModel();
            model.Id = 1;
            model.Name = "Farid Farid";
            model.Titel = "Developer";
            model.imgName = "WhatsApp Image 2024-02-17 at 16.53.47_15646a78.jpg";
            model.Description = "Some text that describes me lorem ipsum ipsum lorem";
            model.Email = "faridfaridFr5@Email.com";
            ListEmployees.AddLast(model);
            //
            model = new EmployeesModel();
            model.Id = 2;
            model.Name = "Ahmed Ahmed";
            model.Titel = "salse";
            model.imgName = "2.jpg";
            model.Description = "Some text that describes me lorem ipsum ipsum lorem";
            model.Email = "faridfaridFr5@Email.com";
            ListEmployees.AddLast(model);
            //
            model = new EmployeesModel();
            model.Id = 3;
            model.Name = "Omar Omar";
            model.Titel = "team leadr";
            model.imgName = "3.jpg";
            model.Description = "Storng team leaf ";
            model.Email = "faridfaridFr5@Email.com";
            ListEmployees.AddLast(model);

            // return
            return ListEmployees;
        }

        public EmployeesModel Find(int Id)
        {
            return new EmployeesModel();
        }
    }
}
