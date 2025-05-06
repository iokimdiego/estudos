// Principais eventos de mouse
const button = document.querySelector('button');

const onMouseClick = () => {
    button.innerText = 'Clicou!';
}

const onMouseEnter = () => {
    button.innerText = 'Mouse entrou!';
}
const onMouseLeave = () => {
    button.innerText = 'Mouse saiu!';
}

button.addEventListener('click', onMouseClick);
button.addEventListener('mouseenter', onMouseEnter);
button.addEventListener('mouseleave', onMouseLeave);

// Principais eventos de teclado


document.body.addEventListener("keydown", (evento) => {
    const novoTexto = document.createElement('h2');
    novoTexto.innerText = `A tecla ${evento.key} foi pressionada`
    document.body.appendChild(novoTexto);
})