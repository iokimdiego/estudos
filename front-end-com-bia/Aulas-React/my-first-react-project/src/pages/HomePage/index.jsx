
import Button from "../../components/Button";

const HomePage = () => {
    const resumeDownloadComplete = true;
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