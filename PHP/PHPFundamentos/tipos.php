<?php

$nome = "Iokim"; // string
$idade = 39; // integer
$preco = 39.90; // double
$casada = true; // boolean

echo gettype($nome);
echo "<br>";
echo gettype($idade);
echo "<br>";
echo gettype($preco);
echo "<br>";
echo gettype($casada);
echo "<br>";

var_dump($nome, $idade, $preco, $casada);

echo "<br>";
echo "A variável nome é do tipo: ";
echo gettype($nome);

$nome = false;

echo "<br>";
echo "A variável nome é do tipo: ";
echo gettype($nome);
