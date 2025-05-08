// const request = fetch('https://meowfacts.herokuapp.com/');
// console.log(request);

// const getCatsFacts = () => {
//     fetch('https://meowfacts.herokuapp.com/')
//         .then((resposta) => resposta.json())
//         .then((catFacts) => console.log(catFacts));
// }

// getCatsFacts();

const getHarryPotterHouses = () => {
    fetch('https://potterapi-fedeperin.vercel.app/pt/houses')
    .then((resposta) => {
        if (!resposta.ok) {
            console.log("A Promise foi rejeitada!");
        }
        return resposta.json()
    })
    .then((data) => {
        if (data.error){
            throw new Error(data.error);
        }
        console.log("Harry Potter Houses:", data)
    })
    .catch((err) => console.log(err));
}

getHarryPotterHouses();