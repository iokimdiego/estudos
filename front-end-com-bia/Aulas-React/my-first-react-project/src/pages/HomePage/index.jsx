
import { useEffect, useState } from "react";
import Button from "../../components/Button";

const HomePage = () => {
    const [resumeDownloadComplete, setResumeDownloadComplete] = useState(false);
    useEffect(() => {
        setTimeout(() => {
            // supondo que dê certo a request que traz o currículo
            setResumeDownloadComplete(true);
        }, 5000)
    }, []);
    
    // const resumeDownloadComplete = true;
   
   
    // const erro = true;

    // if (erro){
    //     return(
    //         <div style={{paddingTop: '100px'}}>
    //             <p>Erro</p>
    //         </div>
    //     )
    // }

    return (
        <section id="homeSection">
            <div id="photoHome"></div>
            <div id="homeContents">
                <div id="homeTexts">
                    <h1 class="titles">Iokim Diego</h1>
                    <h2>Desenvolvedor Full Stack</h2>
                    {
                        resumeDownloadComplete ? (
                            <Button buttonType="downloadResume"/>
                        ) : null
                    }
                </div>
            </div>
        </section>
    )
}
export default HomePage;