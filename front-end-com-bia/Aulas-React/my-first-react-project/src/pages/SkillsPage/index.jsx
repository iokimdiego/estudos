import enviaIcon from "../../assets/icons/envia.svg";
import Button from "../../components/Button";

const SkillsPage = () => (
    <section id="skillsSection">
        <div class="overlay">
            <h1 class="titles">Skills</h1>
            <ul>
                <li>PHP</li>
                <li>MySQL</li>
                <li>HTML</li>
                <li>CSS</li>
                <li>JavaScript</li>
                <li>ES6</li>
                <li>React</li>
                <li>Git</li>
                <li>GitHub</li>
                <li>Figma</li>
                <li>Desenvolvimento Ágil</li>
            </ul>
            <Button buttonType="downloadCompleteResume"/>
        </div>
    </section>
)

export default SkillsPage;