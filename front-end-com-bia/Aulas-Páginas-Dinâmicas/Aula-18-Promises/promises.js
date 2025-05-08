const request = fetch('https://meowfacts.herokuapp.com/');
console.log(request);

// const getCatsFacts = () => {
//     fetch('https://meowfacts.herokuapp.com/')
//         .then((resposta) => resposta.json())
//         .then((catFacts) => console.log(catFacts));
// }

// getCatsFacts();

const getHarryPotterHouses = () => {
    fetch('https://potterapi-fedeperin.vercel.app/pt/houses')
        .then((resposta) => resposta.json())
        .then((harryPotterHouses) => console.log(harryPotterHouses));
}

getHarryPotterHouses();