// ALTERANDO O CONTEÚDO DE ELEMENTOS

const buttonsContainer = document.querySelector('.container');
// buttonsContainer.innerHTML = '<button>Novo Botão</button>'

const firstTitle = document.querySelector('h1');
firstTitle.innerText = "Novo titulo";


// ALTERANDO ESTILOS
buttonsContainer.style.backgroundColor = 'blue';


//ALTERANDO ATRIBUTOS DAS TAGS HTML
const lastTitle = document.getElementById('title4');
title4.setAttribute('id', 'customTitle');

const thirdTitle = document.querySelector('h2:nth-of-type(3)');
thirdTitle.setAttribute('id', 'orangeTitle')

lastTitle.removeAttribute('id');

//ADICIONANDO E REMOVENDO ELEMENTOS

const newLastTitle = document.createElement('h3');
newLastTitle.innerText= 'Título Novo';

document.body.appendChild(newLastTitle);

const newButton = document.createElement('button');
newButton.innerText = 'Novo botão';
newButton.setAttribute('class', 'styleButton boldText');
newButton.classList.add('styleButton', 'boldText');

buttonsContainer.appendChild(newButton);