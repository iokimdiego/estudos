const form = document.querySelector('form');
const geladinhos = document.querySelector('#geladinhos'); // Selecionando o fieldset 'id=geladinhos'
const checkboxes = document.querySelectorAll('input[type="checkbox"]') // Selecionando todos o inputs do tipo checkbox

const sendForm = async(bodyObject) => {
    try {
        const resposta = await fetch('https://jsonplaceholder.typicode.com/posts', {
            method: 'POST',
            body: JSON.stringify(bodyObject),
            headers: {
                'Content-type': 'application/json',
            },
        });
        if (!resposta.ok){
            throw new Error('Ops! Algo deu errado no POST!');
        }
    } catch (err){
        throw err;
    }
}

form.addEventListener('submit', async (evento) => {
    evento.preventDefault();
    const atLeastOneCheckboxMarked = Array.from(checkboxes).some(item => item.checked);
    if(atLeastOneCheckboxMarked){
        const formData = new FormData(form);
        const body = Object.fromEntries(formData.entries());
        body.geladinhos = formData.getAll('geladinhos');
        console.log(body);
        try {
            await sendData(body);
            document.body.innerHTML = '<h1>Formulário Enviado com sucesso!</h1>';
        } catch (err) {
            document.body.innerHTML = '<h1>Ops! Algo deu errado ao submeter o formulário!</h1>';     
        }
    } else {
        const feedback = document.createElement('p');
        feedback.innerText = 'preencha ao menos 1 checkbox';
        feedback.style.color = 'red';
        feedback.style.fontSize = '12px';
        geladinhos.appendChild(feedback);
    }
})

