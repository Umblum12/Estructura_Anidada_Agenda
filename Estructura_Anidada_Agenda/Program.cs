Agenda[] age = new Agenda[5];
age[0].Nombre = "Abelardo";
age[0].Email = "abelardo@hotmail.com";
age[0].direccion.Dirección = 6553;
age[0].direccion.Teléfono = 64447927;
age[0].direccion.Fecha_de_Nacimiento = 2002;

age[1].Nombre = "Aldo";
age[1].Email = "aldito13@hotmail.com";
age[1].direccion.Dirección = 3479;
age[1].direccion.Teléfono = 644130119;
age[1].direccion.Fecha_de_Nacimiento = 2004;

age[2].Nombre = "Danyra";
age[2].Email = "danyam2@hotmail.com";
age[2].direccion.Dirección = 6553;
age[2].direccion.Teléfono = 64422866;
age[2].direccion.Fecha_de_Nacimiento = 2001;

age[3].Nombre = "Joakim";
age[3].Email = "joak9@hotmail.com";
age[3].direccion.Dirección = 1533;
age[3].direccion.Teléfono = 64413489;
age[3].direccion.Fecha_de_Nacimiento = 2009;

age[4].Nombre = "David";
age[4].Email = "david15@hotmail.com";
age[4].direccion.Dirección = 8635;
age[4].direccion.Teléfono = 64445789;
age[4].direccion.Fecha_de_Nacimiento = 1994;

Console.WriteLine("El Nombre del amigo es: {0}, su Email es: {1}, la Direccion es {2}, su Numero de Telefono es: {3} y su Fecha de Nacimiento es: {4}", age[0].Nombre, age[0].Email, age[0].direccion.Dirección, age[0].direccion.Teléfono, age[0].direccion.Fecha_de_Nacimiento);
Console.WriteLine("El Nombre del amigo es: {0}, su Email es: {1}, la Direccion es {2}, su Numero de Telefono es: {3} y su Fecha de Nacimiento es: {4}", age[1].Nombre, age[1].Email, age[1].direccion.Dirección, age[1].direccion.Teléfono, age[1].direccion.Fecha_de_Nacimiento);
Console.WriteLine("El Nombre del amigo es: {0}, su Email es: {1}, la Direccion es {2}, su Numero de Telefono es: {3} y su Fecha de Nacimiento es: {4}", age[2].Nombre, age[2].Email, age[2].direccion.Dirección, age[2].direccion.Teléfono, age[2].direccion.Fecha_de_Nacimiento);
Console.WriteLine("El Nombre del amigo es: {0}, su Email es: {1}, la Direccion es {2}, su Numero de Telefono es: {3} y su Fecha de Nacimiento es: {4}", age[3].Nombre, age[3].Email, age[3].direccion.Dirección, age[3].direccion.Teléfono, age[3].direccion.Fecha_de_Nacimiento);
Console.WriteLine("El Nombre del amigo es: {0}, su Email es: {1}, la Direccion es {2}, su Numero de Telefono es: {3} y su Fecha de Nacimiento es: {4}", age[4].Nombre, age[4].Email, age[4].direccion.Dirección, age[4].direccion.Teléfono, age[4].direccion.Fecha_de_Nacimiento);
Console.ReadKey(true);
struct Agenda
{
    public string Nombre;
    public string Email;
    public Dir direccion;
}
struct Dir
{
    public int Dirección;
    public int Teléfono;
    public int Fecha_de_Nacimiento;
}