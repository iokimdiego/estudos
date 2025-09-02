<?php

$a = 10;
$b = 20;

var_dump($a == $b); // A é igual a B?
echo "<br>";

var_dump($a != $b); // A é diferente de B?
echo "<br>";

var_dump($a <> $b); // A é diferente de B?
echo "<br>";

var_dump($a < $b); // A é menor que B?
echo "<br>";

var_dump($a > $b); // A é maior que B?
echo "<br>";

var_dump($a <= $b); // A é menor ou igual que B?
echo "<br>";

var_dump($a >= $b); // A é maior ou igual que B?
echo "<br>";
echo "<br>";
echo "<br>";

$d = 10;
$e = "10";

echo "o valor de d é igual a e (a == e)?: ";
var_dump($d == $e);
echo "<br>";

echo "o valor e o tipo de d são iguais a e (a === e)?: ";
var_dump($d === $e);
echo "<br>";
echo "<br>";

echo "o valor de d é diferente de e (a != e)?: ";
var_dump($d != $e);
echo "<br>";

echo "o valor e o tipo de d são diferentes de e (a !== e)?: ";
var_dump($d !== $e);
echo "<br>";