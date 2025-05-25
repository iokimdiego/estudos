import coffeeIcon from "../../assets/icons/cube.png";

const NavBar = () => (
    <nav>
        <img src={coffeeIcon} alt="" width="36px"/>
        <ul id="navBarLinks">
            <li><a href="aboutSection">Sobre mim</a></li>
            <li><a href="skillsSection">Skills</a></li>
            <li><a href="">Projetos</a></li>
            <li><a href="contactSection">Contato</a></li>
        </ul>
    </nav>
)

export default NavBar;