using Amozeshyar;
using System.Diagnostics;

Console.WriteLine("***** Wellcome to Amozeshyar *****");
Console.WriteLine("Please Tell me You have account in This site (+/-) :) ");
//char answer = Convert.ToChar(Console.ReadLine()!);
Authentication authentication = new Authentication();
Console.WriteLine("Please enter your Username: ");
string ur = Console.ReadLine()!;
Console.WriteLine("Please enter your password: ");
string pas = Console.ReadLine()!;
bool res1 = authentication.Login(ur, pas);
if (res1)
{
    Console.WriteLine("***** Wellcome *****");
}
else if (!res1)
{
    Console.WriteLine("Please check your information.");
}




void studentMeniue()
{
    Studentservis studentservis = new Studentservis();
    int studentid = authentication.currentuserId();
    bool logout = false;
    do
    {
        Console.WriteLine("1.see list of courses.");
        Console.WriteLine("2.take course.");
        Console.WriteLine("3.see your list of courses.");
        Console.WriteLine("4.take another course.");
        Console.WriteLine("5.Logout.");
        int stanswer = int.Parse(Console.ReadLine()!);

        switch (stanswer)
        {
            case 1:
                studentservis.ShowAllCourses();
                break;
            case 2:
                Console.WriteLine("Please enter the presentation code: ");
                int percode = int.Parse(Console.ReadLine()!);
                studentservis.ShowAllCourses();
                bool res2 = studentservis.TakeCourses(studentid, percode);
                if (!res2)
                {
                    Console.WriteLine("PLease check your information");
                };
                break;
            case 3:
                studentservis.SeeSchedule(studentid);
                break;
            case 4:
                break;
            case 5:
                Repository.Currentuser = null;
                Console.WriteLine("***** Goodbye *****");
                logout = true;
                break;
            default:
                break;
        }
    } while (!logout);
    
}
void teachermeniue()
{
    int Teacheranswer = int.Parse(Console.ReadLine()!);
    int teacherid = authentication.currentuserId();
    bool logout = false;
    do
    {
        Console.WriteLine("1.to add curse.");
        Console.WriteLine("2.see registed students in your classes.");
        Console.WriteLine("3.do something else.");
        Console.WriteLine("4.Logout");
        TeacherService teacherService = new TeacherService();

        switch (Teacheranswer)
        {
            case 1:
                Console.WriteLine("Please enter the name of class.");
                string na = Console.ReadLine();
                Console.WriteLine("Please enter date of class: (i added my self)");
                Console.WriteLine("Please enter the vahed.");
                int vah = int.Parse(Console.ReadLine());
                teacherService.AddCourse(teacherid, na, DateTime.Now, vah);
                break;
            case 2:
                teacherService.SeeStudents(teacherid);
                break;
            case 3:
                break;
            case 4:
                Repository.Currentuser = null;
                Console.WriteLine("***** Goodbye *****");
                logout = true;
                break;
            default:
                break;
        }
    } while (!logout);
}
void opratorMeniue()
{
    OperatorService operatorService = new OperatorService();
    int opId = authentication.currentuserId();
    Studentservis studentservis = new Studentservis();
    bool logout = false;
    do
    {
        Console.WriteLine("1.to manage users.");
        Console.WriteLine("2.to manage courses' capacity.");
        Console.WriteLine("3.to active user.");
        Console.WriteLine("4.do something else.");
        Console.WriteLine("5.Logout.");
        int res5 = int.Parse(Console.ReadLine()!);
        switch (res5)
        {
            case 1:
                operatorService.manageUsers();
                break;
            case 2:
                studentservis.ShowAllCourses();
                Console.WriteLine("Please enter the prasentyation code: ");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter new capacity: ");
                int capa = int.Parse(Console.ReadLine());
                operatorService.ChangeCapacity(code, capa);
                break;
            case 3:
                operatorService.manageUsers();
                Console.WriteLine("Please enter the id: ");
                int ido = int.Parse(Console.ReadLine());
                Console.WriteLine("1.to active this user.");
                Console.WriteLine("1.to deactive this user.");
                int an1 = int.Parse(Console.ReadLine());
                operatorService.CangeStatus(ido, an1);
                break;
            case 4:
                break;
            case 5:
                Repository.Currentuser = null;
                Console.WriteLine("***** Goodbye *****");
                logout = true;
                break;
            default:
                break;
        }
    } while (!logout);
}