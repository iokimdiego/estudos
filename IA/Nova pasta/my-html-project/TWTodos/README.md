# Lista de Tarefas

Uma aplicação web simples para gerenciar suas tarefas diárias, construída com HTML, CSS e JavaScript puro.

## Funcionalidades

- ✅ Adicionar novas tarefas
- 🗑️ Excluir tarefas existentes
- ↕️ Reordenar tarefas por arrastar e soltar
- 💾 Salvamento automático no navegador
- ✍️ Validação de entrada:
  - Mínimo de 3 caracteres
  - Primeira letra maiúscula
  - Não permite tarefas vazias

## Tecnologias Utilizadas

- HTML5
- CSS3
- JavaScript (ES6+)
- Bootstrap 5
- Bootstrap Icons

## Como Executar

1. Clone este repositório:

```bash
git clone [URL-DO-REPOSITÓRIO]
```

2. Navegue até a pasta do projeto:

```bash
cd my-html-project/TWTodos
```

3. Abra o arquivo `index.html` em seu navegador preferido:
   - Dê duplo clique no arquivo
   - Ou arraste o arquivo para uma janela do navegador
   - Ou use um servidor local (recomendado):
     ```bash
     npx http-server
     ```

## Estrutura do Projeto

```
TWTodos/
├── index.html          # Página principal
├── src/
│   ├── css/
│   │   └── styles.css  # Estilos da aplicação
│   └── js/
│       └── main.js     # Lógica da aplicação
└── README.md          # Esta documentação
```

## Como Usar

1. Digite sua tarefa no campo de texto

   - Deve começar com letra maiúscula
   - Deve ter pelo menos 3 caracteres

2. Clique em "Adicionar" ou pressione Enter

3. Para reordenar:

   - Clique e segure o ícone ⋮⋮ ao lado da tarefa
   - Arraste para a nova posição
   - Solte para confirmar

4. Para excluir:
   - Clique no ícone 🗑️ ao lado da tarefa

## Armazenamento

- Todas as tarefas são salvas automaticamente no LocalStorage do navegador
- Os dados persistem mesmo após fechar o navegador
- Cada navegador mantém seu próprio conjunto de tarefas

## Desenvolvimento

Para modificar o projeto:

1. Abra a pasta em seu editor (recomendado VS Code):

```bash
code .
```

2. Faça suas alterações nos arquivos:

   - `index.html` para estrutura
   - `src/css/styles.css` para estilos
   - `src/js/main.js` para lógica

3. Recarregue a página para ver as alterações

## Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.
