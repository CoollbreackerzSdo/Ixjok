var client = new HttpClient()
{
    BaseAddress = new("https://ixjok.runasp.net/")
}; 

client.DefaultRequestHeaders.Authorization = new("bearer","eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIwMTlhZGE5Yi1jZmE3LTdkNTctOWU4MS0wY2U4ZDU4ZDFiYWYiLCJuYW1lIjoicmFsYmVyIiwiZXhwIjoxNzY0NjA3ODM1LCJpc3MiOiJDb29sbGJyZWFja2VyeiIsImF1ZCI6Imh0dHBzOi8vaXhqb2sucnVuYXNwLm5ldC8ifQ.Vm3d-1OvhH6_bNbP6tQnFMikVxw9JyAMMyGxyJX2GRg");
var result = await client.GetAsync("notes");
Console.WriteLine(await result.Content.ReadAsStringAsync());