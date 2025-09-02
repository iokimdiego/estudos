<?php

$escola = "Treinaweb";
$curso = "PHP";

$frase = "Faça o curso de " . $curso . " na escola " . $escola;

echo $frase;

echo "<br>";
echo "<br>";
echo "<br>";

// Declaração de Strings com "" ou ''

$string1 = "Faça o curso de $curso na escola $escola!"; // Com aspas duplas, interpreta as variáveis
$string2 = 'Faça o curso de $curso na escola $escola!'; // Com aspas simples, tudo vira texto

echo $string1;
echo "<br>";
echo $string2;

// Por convenção, se coloca a variável entre {}, principalmente se nesse trecho de código será necessário uma interpretação mais complexa, exemplo uma array.
// $string1 = "Faça o curso de {$curso[2]} na escola {$escola[3]}!";