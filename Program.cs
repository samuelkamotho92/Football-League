using Football_League.Services;
using Football_League.Services.TeamService;

Dictionary<int, string> options = new Dictionary<int, string>();
Console.WriteLine("Choose Options");
options.Add(1, "Create Team");
options.Add(2, "Read Teams");
options.Add(3,"Update Teams");
options.Add(4, "Delete Teams");
options.Add(5, "Cancel operation");
foreach (var option in options)
{
    Console.WriteLine($"{option.Key}:{option.Value}");
}
int userInpt = int.Parse(Console.ReadLine());
if (userInpt == 1)
{

    Create teamOne = new Create();
    teamOne.createTeam();
}else if (userInpt == 2)
{
    Read teams = new Read();
    teams.readTeam();
}else  if(userInpt == 3)
{
 Update team = new Update();
    team.updateTeam();
}else if (userInpt == 4)
{
    Deleted team = new Deleted();
    team.deleteTeam();
}
else
{
    Console.WriteLine("Opertaion ended");
}