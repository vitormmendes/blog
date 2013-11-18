string valor1 = "10";

try
{
    Int32.Parse(valor1);
}
catch (FormatException ex)
{ 
    /* Devido tratamento aqui */ 
}
catch (OverflowException ex)
{
    /* Devido tratamento aqui */ 
}
catch (ArgumentException ex)
{ 
    /* Devido tratamento aqui */
}