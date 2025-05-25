import envelopeIcon from "../../assets/icons/envelope-regular.svg";
import whatsappIcon from "../../assets/icons/whatsapp-brands.svg";
import linkedinIcon from "../../assets/icons/linkedin.svg";
import instagramIcon from "../../assets/icons/instagram-brands.svg";
import githubIcon from "../../assets/icons/github-brands.svg";

const ContactPage = () => (
    <section id="contactSection">
        <div id="textContactContainer">
            <div id="textContactChild">
                <h1 class="titles">Contato</h1>
                <p class="customLineHeight">Gostaria de bater um papo comigo? Vou deixar todas as minhas formas de contato e redes sociais listadas abaixo</p>
                <address class="emailAndPhone">
                    <div class="itemContact">
                        <img class="contactIcon" src={envelopeIcon} alt=""/>
                        <p>iokimdiego@hotmail.com</p>
                    </div>
                    <div class="itemContact">
                        <img class="contactIcon" src={whatsappIcon} alt="" />
                        <p>+55 (92) 9 8194-0300</p>
                    </div>
                </address>
                <div class="socialMedia">
                    <a href="https://www.linkedin.com/in/iokimdiego/" target="_blank"><img class="linkIcon" src={linkedinIcon} alt=""/></a>
                    <a href="https://www.instagram.com/iokimdiego" target="_blank"><img class="linkIcon" src={instagramIcon} alt=""/></a>
                    <a href="https://github.com/iokimdiego/iokimdiego" target="_blank"><img class="linkIcon" src={githubIcon} alt=""/></a>
                </div>
            </div>
        </div>
        <div id="photoContact"></div>
    </section>
)

export default ContactPage;