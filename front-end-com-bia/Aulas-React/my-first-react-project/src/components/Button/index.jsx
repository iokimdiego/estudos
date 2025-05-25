import './styles.css';
import enviaIcon from "../../assets/icons/envia.svg";
import linkedinIcon from "../../assets/icons/linkedin.svg";

const Button = ({buttonType}) => {
    // downloadResume, dowloadCompleteResume, linkedIn
    const getButtonProps = () => {
        switch (buttonType) {
            case 'downloadResume':
                return {
                    icon: enviaIcon,
                    href: 'sources/Desenvolvedor Front-End - Iokim Diego Martins e Silva.pdf',
                    download: 'Desenvolvedor Front-End - Iokim Diego Martins e Silva.pdf',
                    buttonText: 'Baixar currículo',
                    colorClass: 'downloadButtonLight'
                }
                // break;
            case 'downloadCompleteResume':
                return {
                    icon: enviaIcon,
                    href: 'sources/Desenvolvedor Front-End - Iokim Diego Martins e Silva.pdf',
                    download: 'Desenvolvedor Front-End - Iokim Diego Martins e Silva.pdf',
                    buttonText: 'Baixar currículo Completo',
                    colorClass: 'downloadButtonDark'
                }
                // break;
            case 'linkedIn':
                return {
                    icon: linkedinIcon,
                    href: 'https://www.linkedin.com/in/iokimdiego/',
                    download: null,
                    buttonText: 'Confira meu LinkedIn',
                    colorClass: 'linkedinButton'
                }
                // break;
        
            default:
                break;
        }
    }

    return (
        <div className={`defaultButton downloadButtonLight ${getButtonProps().colorClass}`}>
            <img src={getButtonProps().icon} width="18px" alt=""/>
            <a 
                href={getButtonProps().href} 
                download={getButtonProps().download}
                target={getButtonProps().download ? null : '_blank'}
            >
                {getButtonProps().buttonText}
            </a>
        </div>
    )

}

export default Button;