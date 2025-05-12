// const getHarryPotterHouses = () => {
//     fetch('https://potterapi-fedeperin.vercel.app/pt/houses')
//     .then((resposta) => {
//         if (!resposta.ok) {
//             console.log("A Promise foi rejeitada!");
//         }
//         return resposta.json()
//     })
//     .then((data) => {
//         if (data.error){
//             throw new Error(data.error);
//         }
//         console.log("Harry Potter Houses:", data)
//     })
//     .catch((err) => console.log(err));
//}

const getHarryPotterHouses = async () => {
    try{
        const resposta = await fetch('https://potterapi-fedeperin.vercel.app/pt/houses');
        const dados = await resposta.json();
        if (dados.error){
            throw new Error(dados.error);
        }
        if (!resposta.ok){
            const status = resposta.status;
            throw new Error('Ops! Algo deu errado!');
            console.log('Status do Erro:', status);
        }
        console.log("Dados: ", dados);
    } catch (err){
        console.log(err);
    }
}

getHarryPotterHouses();