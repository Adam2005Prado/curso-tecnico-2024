<?php
$nome=$_GET["nome"];
$email=$_GET["email"];
$mensagem=$_GET["mensagem"];
$genero=$_GET["genero"];
$foto=$_FILES["foto"]["tmp_name"];

if ($nome=="" && $email="" ){
    echo" Campo nome ou email em branco!";
    
} else{
    echo"Ola $nome<br>";
    echo"com email $email<br>";
    echo"confirma o recebimento $mensagem <br>";
    echo"Genero: $genero";
    move_uploaded_file(foto,'/uploads/');
    echo "<img src=/uploads/.$foto>";
}





?>