using System.Buffers.Text;
using System.Runtime.InteropServices;
using System.Text;

Console.WriteLine("***** Testes com .NET 9 | Encode/Decode com Base64Url *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

const string valorOriginal = "Testes com .NET 9";
Console.WriteLine($"Valor original = {valorOriginal}");

ReadOnlySpan<byte> bytes = Encoding.UTF8.GetBytes(valorOriginal);

Console.WriteLine();
var encodedBase64 = Convert.ToBase64String(bytes);
Console.WriteLine($"Convert.ToBase64String() = {encodedBase64}");
Console.WriteLine($"Convert.FromBase64String() = {Encoding.UTF8.GetString(
    Convert.FromBase64String(encodedBase64))}");

Console.WriteLine();
string encodedBase64Url = Base64Url.EncodeToString(bytes);
Console.WriteLine($"Encoding com Base64Url = {encodedBase64Url}");
Console.WriteLine($"Decoding com Base64Url = {Encoding.UTF8.GetString(
    Base64Url.DecodeFromChars(encodedBase64Url.AsSpan()))}");