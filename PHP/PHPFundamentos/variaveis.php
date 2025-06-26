<?php

// por boa prática, declara variáveis com letras minúsculas

$email = "iokimdiego@hotmail.com";

echo $email;

$email = "iokimdiego@gmail.com";

echo "<br>";

echo $email;

$email = 100;

echo "<br>";

echo $email;


// Os nomes de variáveis sempre começam com o caractere $ (cifrão). Exemplo: $idade
// São sensíveis à letra (case sensitive), ou seja, $Valor é diferente de $valor.
// Um nome de variável válido deve iniciar com um sublinhado OU uma letra, nunca deve ser iniciado com um número ou caractere especial.

//Devemos sempre declarar nomes de variáveis que façam sentido ao contexto de desenvolvimento, por exemplo:
$nome = "Elton";
$sobrenome = "Fonseca";
$idade = 28;
//nunca:
$a1 = "Elton";
$a2 = "Fonseca";
$a3 = 28;