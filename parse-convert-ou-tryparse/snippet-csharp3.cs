string valor1 = "abc";
string valor2 = "12345678901";
string valor3 = null;
string valor4 = "10";

int resultado;

if (Int32.TryParse(valor1, out resultado)) // Retorno 'False', valor da variável 'resultado' é igual a 0
{ /* Seu código */ }

if (Int32.TryParse(valor2, out resultado)) // Retorno 'False', valor da variável 'resultado' é igual a 0
{ /* Seu código */ }

if (Int32.TryParse(valor3, out resultado)) // Retorno 'False', valor da variável 'resultado' é igual a 0
{ /* Seu código */ }

if (Int32.TryParse(valor4, out resultado)) // Retorno 'True', valor da variável 'resultado' é igual a 10
{ /* Seu código */ }