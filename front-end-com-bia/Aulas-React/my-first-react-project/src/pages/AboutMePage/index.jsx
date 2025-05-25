
import Button from "../../components/Button";

const AboutPage = () => (
    <section id="aboutSection">
        <div id="textsAboutMeFlexContainer">
            <div id="textsAboutMeFlexItem">
                <h1 class="titles">Sobre mim</h1>
                <p class="customLineHeight">Profissional em transição de carreira
                    para o Desenvolvimento Front-End,
                    com sólida experiência administrativa
                    nos setores público e privado. Ao
                    longo da minha trajetória, desenvolvi
                    habilidades como responsabilidade,
                    proatividade, empatia e pensamento
                    analítico.
                </p>
                <Button buttonType="linkedIn"/>
            </div>
        </div>
        <div id="photoAboutMe"></div>
    </section>
)

export default AboutPage;