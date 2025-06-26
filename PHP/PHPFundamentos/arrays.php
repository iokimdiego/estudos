<?php

$linguagem = ["PHP", "C#", "Java"];

echo $linguagem[0];
echo "<br>";


// Arrays Associativos

$curso = ["Curso de PHP Fundamentos", 7.4, 40, true]; // não é intuitivo. Precisamos criar chaves para identificar cada campo

$curso = [
    "nome_curso" => "Curso de PHP Fundamentos",
    "versao_ferramenta" => 7.4,
    "carga_horaria" => 40,
    "status" => true
];

echo $curso["nome_curso"];
echo "<br>";
echo $curso["versao_ferramenta"];
echo "<br>";
echo $curso["carga_horaria"];
echo "<br>";
echo $curso["status"];

echo "<br>";
echo "<br>";
echo "<br>";



// Arrays multidimensionais
$numeros = [
    [1, 2, 3, 4],
    [5, 6, 7, 8, 9],
    [10, 11]
];

echo $numeros[0][2]; // retorna o número que está na primeira linha [0] e 3ª coluna [2]. Resultado = 3
echo "<br>";
echo $numeros[2][1]; // retorna o número que está na primeira linha [0] e 3ª coluna [2]. Resultado = 3
echo "<br>";
echo "<br>";
echo "<br>";

$cursos = [
    "php" => [
        "nome_curso" => "Curso de PHP Fundamentos",
        "versao_ferramenta" => 7.4,
        "carga_horaria" => 40,
        "status" => true
    ],
    "java" => [
        "nome_curso" => "Curso de Java Fundamentos",
        "versao_ferramenta" => 11.4,
        "carga_horaria" => 30,
        "status" => false
    ],
];

echo $cursos["php"]["nome_curso"];
echo "<br>";
echo $cursos["java"]["nome_curso"];



// Adicionar novos itens ao array
$linguagem[3] = "Python";
var_dump($linguagem);

$cursos["php"]["pre-requisito"] = "Lógica de Programação";
echo "<br>";
echo $cursos["php"]["pre-requisito"];

$paises = [
    'Namibia',
    'Nauru',
    'Nepal',
    'Netherlands',
    'New Zealand',
    'Nicaragua',
    'Niger',
    'Nigeria',
    'North Korea',
    'Norway'
];

echo "<br>";
echo "<br>";
echo "<br>";

echo $paises[0];
echo " ";
echo $paises[1];
echo " ";
echo $paises[2];
echo " ";
echo $paises[3];
echo " ";
echo $paises[4];
echo " ";
echo $paises[5];
echo " ";
echo $paises[6];
echo " ";
echo $paises[7];
echo " ";
echo $paises[8];
echo " ";
echo $paises[9];
echo " ";