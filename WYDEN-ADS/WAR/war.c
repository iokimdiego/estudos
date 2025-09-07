// ============================================================================
//         PROJETO WAR ESTRUTURADO - DESAFIO DE CÓDIGO
// ============================================================================
//             ALUNO: IOKIM DIEGO MARTINS E SILVA       
// ============================================================================
//
// OBJETIVOS:
// - Modularizar completamente o código em funções especializadas.
// - Implementar um sistema de missões para um jogador.
// - Criar uma função para verificar se a missão foi cumprida.
// - Utilizar passagem por referência (ponteiros) para modificar dados e
//   passagem por valor/referência constante (const) para apenas ler.
// - Foco em: Design de software, modularização, const correctness, lógica de jogo.
//
// ============================================================================

// Inclusão das bibliotecas padrão necessárias para entrada/saída, alocação de memória, manipulação de strings e tempo.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// --- Constantes Globais ---
// Definem valores fixos para o número de territórios, missões e tamanho máximo de strings, facilitando a manutenção.
#define MAX_TERRITORIO 5
#define TAM_STRING 100

// --- Estrutura de Dados ---
// Define a estrutura para um território, contendo seu nome, a cor do exército que o domina e o número de tropas.
struct Territorio{
    char nome[TAM_STRING];
    char cor[TAM_STRING];
    int tropas;
};

// --- Protótipos das Funções ---
// Declarações antecipadas de todas as funções que serão usadas no programa, organizadas por categoria.

// Funções de setup e gerenciamento de memória:
void limparBufferEntrada(); 

// Funções de interface com o usuário:
void menuOpcoes();
// Funções de lógica principal do jogo:
// Função utilitária:

// --- Função Principal (main) ---
// Função principal que orquestra o fluxo do jogo, chamando as outras funções em ordem.
int main() {
    struct Territorio territorios[MAX_TERRITORIO];
    int totalTerritorios = 0;
    int opcao;
    int simNao; // Variável para controlar se o usuário quer continuar cadastrando territórios
    
    // 1. Configuração Inicial (Setup):
    
    do{
        menuOpcoes(); // Chama a função de interface padrão
        printf("1 - Criar novo Territorio\n");
        printf("2 - Listar todos os Territorios\n");
        printf("0 - Sair\n");
        printf("...........................................\n");
        printf("Escolha uma opcao: ");
        // Lê a opção do usuário.
        scanf("%d", &opcao);
        limparBufferEntrada(); // Limpa o '\n' deixado pelo scanf.
        
        // --- Processamento da Opção ---
        switch (opcao){
            case 1: // Criar novo território
                simNao = 1; // Inicializa para entrar no loop
                
                while (simNao == 1) // Continua enquanto o usuário quiser cadastrar novos territórios
                {
                    if(totalTerritorios < MAX_TERRITORIO && simNao == 1) {
                        menuOpcoes();
                        printf("    1 - Criar novo Territorio\n");
                        printf("\n");
                        printf("...........................................\n");
                        printf("\n");
            
                        printf("Digite o nome do Territorio: ");
                        fgets(territorios[totalTerritorios].nome, TAM_STRING, stdin);
            
            
                        printf("Informe a cor do Territorio: ");
                        fgets(territorios[totalTerritorios].cor, TAM_STRING, stdin);
            
                        territorios[totalTerritorios].nome[strcspn(territorios[totalTerritorios].nome, "\n")]= '\0';
                        territorios[totalTerritorios].cor[strcspn(territorios[totalTerritorios].cor, "\n")]= '\0';
            
                        printf("Informe a quantidade de tropas do Territorio: ");
                        scanf("%d", &territorios[totalTerritorios].tropas);
                        limparBufferEntrada();
            
                        totalTerritorios++;
            
                        printf("\nTerritorio criado com sucesso!\n");

                    } else {
                        printf("Quantidade maxima atingida! Nao foi possivel criar um novo territorio.");
                        simNao = 0; // Sai do loop se atingir o máximo
                        
                        break;
                    }
                    
                    // Lista os territórios já cadastrados
                    menuOpcoes();
                    printf("   2 - Listar todos os Territorios\n");
                    printf("\n");
                    printf("...........................................\n");
                    printf("\n");
                    for (int i = 0; i < totalTerritorios; i++){
                        printf("---------------------------------------------------------\n");
                        printf("TERRITORIO %d\n", i + 1);
                        printf("Nome: %s\n", territorios[i].nome);
                        printf("Cor: %s\n", territorios[i].cor);
                        printf("Tropas: %d\n", territorios[i].tropas);
                    }
                    printf("...........................................\n");
                    
                    printf("\n");
                    printf("Deseja cadastrar outro territorio?\n");
                    printf("1 - Sim\n");
                    printf("0 - Nao\n");
                    printf("Escolha uma opcao: ");
                    // Lê a opção do usuário.
                    scanf("%d", &simNao);
                    limparBufferEntrada(); // Limpa o '\n' deixado pelo scanf.
                }

                printf("\nPressione Enter para voltar ao Menu Principal...");
                getchar(); // Pausa para o usuário ler a mensagem antes de voltar ao menu.
                break;
                
            case 2: // Listar todos os territórios cadastrados
                if (totalTerritorios == 0) {
                    printf("\n");
                    printf("Nenhum territorio criado!\n");
                } else {
                    menuOpcoes();
                    printf("   2 - Listar todos os Territorios\n");
                    printf("\n");
                    printf("...........................................\n");
                    printf("\n");
                    for (int i = 0; i < totalTerritorios; i++){
                        printf("---------------------------------------------------------\n");
                        printf("TERRITORIO %d\n", i + 1);
                        printf("Nome: %s\n", territorios[i].nome);
                        printf("Cor: %s\n", territorios[i].cor);
                        printf("Tropas: %d\n", territorios[i].tropas);
                    }
                    printf("...........................................\n");
                }

                printf("\nPressione Enter para voltar ao Menu Principal...");
                getchar(); // Pausa para o usuário ler a mensagem antes de voltar ao menu.
                break;

            case 0: //Sair do jogo
                system("cls"); // Limpa a tela do console;
                printf("\nSaindo do jogo...\n");
                break;
            
            default: // Opção inválida
                printf("\nOpcao invalida! Tente novamente.\n");
                printf("\nPressione Enter para continuar...");
                getchar();
                break;
        }
    } while (opcao != 0);
    
    // - Define o locale para português.
    // - Inicializa a semente para geração de números aleatórios com base no tempo atual.
    // - Aloca a memória para o mapa do mundo e verifica se a alocação foi bem-sucedida.
    // - Preenche os territórios com seus dados iniciais (tropas, donos, etc.).
    // - Define a cor do jogador e sorteia sua missão secreta.

    // 2. Laço Principal do Jogo (Game Loop):
    // - Roda em um loop 'do-while' que continua até o jogador sair (opção 0) ou vencer.
    // - A cada iteração, exibe o mapa, a missão e o menu de ações.
    // - Lê a escolha do jogador e usa um 'switch' para chamar a função apropriada:
    //   - Opção 1: Inicia a fase de ataque.
    //   - Opção 2: Verifica se a condição de vitória foi alcançada e informa o jogador.
    //   - Opção 0: Encerra o jogo.
    // - Pausa a execução para que o jogador possa ler os resultados antes da próxima rodada.

    // 3. Limpeza:
    // - Ao final do jogo, libera a memória alocada para o mapa para evitar vazamentos de memória.

    return 0; // Fim do Jogo
}

// --- Implementação das Funções ---

// alocarMapa():
// Aloca dinamicamente a memória para o vetor de territórios usando calloc.
// Retorna um ponteiro para a memória alocada ou NULL em caso de falha.

// inicializarTerritorios():
// Preenche os dados iniciais de cada território no mapa (nome, cor do exército, número de tropas).
// Esta função modifica o mapa passado por referência (ponteiro).

// liberarMemoria():
// Libera a memória previamente alocada para o mapa usando free.

// exibirMenuPrincipal():
// Imprime na tela o menu de ações disponíveis para o jogador.

// exibirMapa():
// Mostra o estado atual de todos os territórios no mapa, formatado como uma tabela.
// Usa 'const' para garantir que a função apenas leia os dados do mapa, sem modificá-los.

// exibirMissao():
// Exibe a descrição da missão atual do jogador com base no ID da missão sorteada.

// faseDeAtaque():
// Gerencia a interface para a ação de ataque, solicitando ao jogador os territórios de origem e destino.
// Chama a função simularAtaque() para executar a lógica da batalha.

// simularAtaque():
// Executa a lógica de uma batalha entre dois territórios.
// Realiza validações, rola os dados, compara os resultados e atualiza o número de tropas.
// Se um território for conquistado, atualiza seu dono e move uma tropa.

// sortearMissao():
// Sorteia e retorna um ID de missão aleatório para o jogador.

// verificarVitoria():
// Verifica se o jogador cumpriu os requisitos de sua missão atual.
// Implementa a lógica para cada tipo de missão (destruir um exército ou conquistar um número de territórios).
// Retorna 1 (verdadeiro) se a missão foi cumprida, e 0 (falso) caso contrário.

// limparBufferEntrada():
// Função utilitária para limpar o buffer de entrada do teclado (stdin), evitando problemas com leituras consecutivas de scanf e getchar.
void limparBufferEntrada() {
    int c;
    while ((c = getchar()) != '\n' && c != EOF);
}

//menuOpcoes():
// Função para reaproveitamento de código e padronização da interface
void menuOpcoes() {
    system("cls"); // Limpa a tela do console;
    printf("===========================================\n");
    printf("    WAR 2025 - CONQUISTE O MUNDO!\n");
    printf("===========================================\n");
    printf("         CONFIGURACAO - SETUP\n");
    printf("===========================================\n");
    printf("\n");
}
