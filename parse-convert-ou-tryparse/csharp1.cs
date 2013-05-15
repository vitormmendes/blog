string valor1 = "abc";
string valor2 = "12345678901";
string valor3 = null;
string valor4 = "10";

Int32.Parse(valor1); // FormatException
Int32.Parse(valor2); // OverflowException
Int32.Parse(valor3); // ArgumentException
Int32.Parse(valor4); // 10