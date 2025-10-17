// Todo app logic

const STORAGE_KEY = 'twtodos.todos';

function loadTodos() {
    const raw = localStorage.getItem(STORAGE_KEY);
    try {
        return raw ? JSON.parse(raw) : [];
    } catch {
        return [];
    }
}

function saveTodos(todos) {
    localStorage.setItem(STORAGE_KEY, JSON.stringify(todos));
}

function validateTodo(text) {
    // At least 3 chars and starts with capital letter
    if (!text.trim()) return false;
    if (!/^[A-ZÀ-Ú]/.test(text.trim())) {
        document.getElementById('todo-error').textContent = 'A tarefa deve começar com letra maiúscula.';
        return false;
    }
    if (text.trim().length < 3) {
        document.getElementById('todo-error').textContent = 'A tarefa deve ter pelo menos 3 caracteres.';
        return false;
    }
    return true;
}

function renderTodos() {
    const list = document.getElementById('todo-list');
    list.innerHTML = '';

    const todos = loadTodos();
    todos.forEach((todo, idx) => {
        const li = document.createElement('li');
        li.className = 'list-group-item d-flex justify-content-between align-items-center';
        li.dataset.index = idx;
        li.draggable = true;

        const dragHandle = document.createElement('div');
        dragHandle.className = 'drag-handle me-2';
        dragHandle.innerHTML = '⋮⋮';

        const text = document.createElement('span');
        text.textContent = todo;
        text.className = 'todo-text flex-grow-1';

        const del = document.createElement('button');
        del.className = 'btn btn-danger btn-sm ms-2';
        del.title = 'Excluir';
        del.innerHTML = '<i class="bi bi-trash"></i>';
        del.onclick = () => deleteTodo(idx);

        // Add drag event listeners
        li.addEventListener('dragstart', handleDragStart);
        li.addEventListener('dragenter', handleDragEnter);
        li.addEventListener('dragover', handleDragOver);
        li.addEventListener('dragleave', handleDragLeave);
        li.addEventListener('drop', handleDrop);
        li.addEventListener('dragend', handleDragEnd);

        li.appendChild(dragHandle);
        li.appendChild(text);
        li.appendChild(del);
        list.appendChild(li);
    });
}

function addTodo(text) {
    const errorEl = document.getElementById('todo-error');
    if (!validateTodo(text)) {
        if (!errorEl.textContent) {
            errorEl.textContent = 'A tarefa deve começar com letra maiúscula e ter pelo menos 3 caracteres.';
        }
        return false;
    }
    errorEl.textContent = '';
    const todos = loadTodos();
    todos.push(text.trim());
    saveTodos(todos);
    renderTodos();
    return true;
}

function deleteTodo(index) {
    const todos = loadTodos();
    if (index < 0 || index >= todos.length) return;
    todos.splice(index, 1);
    saveTodos(todos);
    renderTodos();
}

function moveUp(index) {
    const todos = loadTodos();
    if (index <= 0 || index >= todos.length) return;
    [todos[index-1], todos[index]] = [todos[index], todos[index-1]];
    saveTodos(todos);
    renderTodos();
}

function moveDown(index) {
    const todos = loadTodos();
    if (index < 0 || index >= todos.length - 1) return;
    [todos[index+1], todos[index]] = [todos[index], todos[index+1]];
    saveTodos(todos);
    renderTodos();
}

// Drag and drop handlers
let draggedItem = null;

function handleDragStart(e) {
    draggedItem = this;
    this.classList.add('dragging');
    e.dataTransfer.effectAllowed = 'move';
}

function handleDragEnter(e) {
    e.preventDefault();
    if (this !== draggedItem) {
        this.classList.add('drag-over');
    }
}

function handleDragOver(e) {
    e.preventDefault();
    e.dataTransfer.dropEffect = 'move';
}

function handleDragLeave(e) {
    this.classList.remove('drag-over');
}

function handleDrop(e) {
    e.preventDefault();
    if (this === draggedItem) return;
    
    const todos = loadTodos();
    const fromIndex = parseInt(draggedItem.dataset.index);
    const toIndex = parseInt(this.dataset.index);
    
    // Reorder array
    const [movedItem] = todos.splice(fromIndex, 1);
    todos.splice(toIndex, 0, movedItem);
    
    saveTodos(todos);
    renderTodos();
}

function handleDragEnd() {
    this.classList.remove('dragging');
    document.querySelectorAll('.drag-over').forEach(el => {
        el.classList.remove('drag-over');
    });
}

// Wire up form
document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('todo-form');
    const input = document.getElementById('todo-input');

    form.addEventListener('submit', (e) => {
        e.preventDefault();
        if (addTodo(input.value)) {
            input.value = '';
            input.focus();
        }
    });

    renderTodos();
});