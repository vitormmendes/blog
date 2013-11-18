string valor1 = "abc";
string valor2 = "12345678901";
string valor3 = null;
string valor4 = "10";

Convert.ToInt32(valor1); // FormatException
Convert.ToInt32(valor2); // OverflowException
Convert.ToInt32(valor3); // 0 
Convert.ToInt32(valor4); // 10