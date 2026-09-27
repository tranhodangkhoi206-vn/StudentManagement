Console.Write("Username: ");
string user = Console.ReadLine();
Console.Write("Password: ");
string pass = Console.ReadLine();
if (user == "admin" && pass == "123")
    Console.WriteLine("Đăng nhập thành công!");
else
    Console.WriteLine("Sai tài khoản hoặc mật khẩu!");
