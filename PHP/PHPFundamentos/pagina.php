<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página PHP</title>
</head>
<body>
    <h1>Minha primeira página PHP</h1>
    <?php echo "Aqui começa a minha string em PHP" ?>
    
    <p>Estou no curso de <?php echo "PHP"; ?></p>
    <p>10 mais 10 é igual a <?php echo 10+10; ?></p>
    
    <p>Estou no curso de <?= "PHP" ?></p> <!-- Short tag -->
    <p>10 mais 10 é igual a <?= 10+10 ?></p> <!-- Short tag -->

    <?php
        echo "minha linha 1 <br>";
        echo "minha linha 2 <br>";
        echo "minha linha 3";
    ?>
</body>
</html>