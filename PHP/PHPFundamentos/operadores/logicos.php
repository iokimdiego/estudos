<?php

$a = true;
$b = false;

// && and (e simples: quando todos são verdadeiros, retorna verdadeiro)
var_dump($a && $b);
echo "<br>";
var_dump($a and $b);
echo "<br>";
echo "<br>";


// || or (ou simples: quando um dos valores é verdadeiro, retorna verdadeiro )
var_dump($a || $b);
echo "<br>";
var_dump($a or $b);
echo "<br>";

// || xor (ou exclusivo: quando somente um dos valores é verdadeiro, retorna verdadeiro)
var_dump($a || $b);
echo "<br>";
var_dump($a or $b);

echo "<br>";
echo "<br>";
echo "<br>";

// ! negação
echo "b é: ";
var_dump($b);
echo "<br>";

echo "Agora b é: ";
var_dump (!$b);