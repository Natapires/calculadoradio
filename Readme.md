<h1 align="TESTE UNITÁRIO EM C#</h1>

UMA DOCUMENTAÇÃO RESUMIDA PARA MOSTRAR O FUNCIONAMENTO DESSE PROJETO. FOI DESENVOLVIDO UMA CALCULADORA E IMPLEMENTADO TESTE.

- Criei duas pasta, uma para Calculadora que será meu projeto em si, e uma CalculadoraTeste que será os testes em si.

Para iniciar um projeto em C# .NET:

`dotnet new console`

Para iniciar um projeto de teste utilizando um framework:

`dotnet new unit`

para executar o código de teste, utilizamos o seguinte comando:

`dotnet test`

Nesse projeto eu utilizei o Theory e o InlineData:

Theory: Conjunto de cenários que vai passar pelos mesmo teste.
InlineData: Serve para passar parametros para os seus testes, e para cada InlineData é um teste diferente.
