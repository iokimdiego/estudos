const form = document.querySelector('form');

form.addEventListener('submit', (evento) => {
    evento.preventDefault();
    console.log("Enviando seus dados do formulário");
})