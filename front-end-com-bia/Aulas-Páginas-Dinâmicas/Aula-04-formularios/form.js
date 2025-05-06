const form = document.querySelector('form');
const geladinhos = document.querySelector('#geladinhos'); // Selecionando o fieldset 'id=geladinhos'
const checkboxes = document.querySelectorAll('input[type="checkbox"]') // Selecionando todos o inputs do tipo checkbox

form.addEventListener('submit', (evento) => {
    const atLeastOneCheckboxMarked = Array.from(checkboxes).some(item => item.checked);
    
    evento.preventDefault();
    if(atLeastOneCheckboxMarked){
        console.log("Enviando seus dados do formulário");
        document.body.innerHTML = '<h1>Formulário Enviado com sucesso!</h1>';
    } else {
        const feedback = document.createElement('p');
        feedback.innerText = 'preencha ao menos 1 checkbox';
        feedback.style.color = 'red';
        feedback.style.fontSize = '12px';
        geladinhos.appendChild(feedback);
    }
})

