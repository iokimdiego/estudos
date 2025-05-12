const getToDos = async () => {
    try {
        const resposta = await fetch ('https://jsonplaceholder.typicode.com/posts');
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(dados.error);
        }
        if(!resposta.ok){
            throw new Error('Ops! Algo deu errado no GET!');
        }
        console.log("Dados do GET: ", dados);
    } catch (err){
        console.log(err);
    }
}

// Método GET
// getToDos();

// Método POST

const publishNewPost = async() => {
    try {
        const resposta = await fetch ('https://jsonplaceholder.typicode.com/posts', {
            method: 'POST',
            body: JSON.stringify({
                title: 'foo',
                body: 'bar',
                userId: 1,
            }),
            headers: {
                'Content-type': 'application/json',
            },
        });
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(data.error);
        }
        if (!resposta.ok){
            throw new Error('Ops! Algo deu errado no POST!');
        }
        console.log("Resposta do POST: ", dados);
    } catch (err){
        console.log(err);
    }
}

// publishNewPost();

// Método PUT
const editPost = async() => {
    try {
        const resposta = await fetch('https://jsonplaceholder.typicode.com/posts/1', {
            method: 'PUT',
            body: JSON.stringify({
                title: 'foo',
                body: 'bar',
                userId: 1,
            }),
            headers: {
                'Content-type': 'application/json',
            },
        });
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(data.error);
        }
        if (!resposta.ok){
            throw new Error('Ops! Algo deu errado no PUT!');
        }
        console.log("Resposta do PUT: ", dados);
    } catch(err){
        console.log(err);
    }
}

// editPost();

// Método PATCH
// Semelhando ao PUT, porém serve para editar apenas uma propriedade de um registro
const editPostTitle = async() => {
    try {
        const resposta = await fetch('https://jsonplaceholder.typicode.com/posts/1', {
            method: 'PATCH',
            body: JSON.stringify({
                title: 'foo',
            }),
            headers: {
                'Content-type': 'application/json',
            },
        });
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(data.error);
        }
        if (!resposta.ok){
            throw new Error('Ops! Algo deu errado no PATCH!');
        }
        console.log("Resposta do PATCH: ", dados);
    } catch(err){
        console.log(err);
    }
}

// editPostTitle();

// Método DELETE
const deletePost = async() => {
    try {
        const resposta = await fetch('https://jsonplaceholder.typicode.com/posts/1', {
            method: 'DELETE',
        });
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(data.error);
        }
        if (!resposta.ok){
            throw new Error('Ops! Algo deu errado no DELETE!');
        }
        console.log("Resposta do DELETE: ", dados);
    } catch(err){
        console.log(err);
    }
}

deletePost();
