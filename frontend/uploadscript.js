async function upload(ev)
{
    ev.preventDefault();

    const fileInput = document.getElementById('fileInput');

    if (fileInput.files.length == 0)
        return;

    const formData = new FormData();
    formData.append('file', fileInput.files[0]);

    try {
        const response = await fetch('/api/upload/upload', {
            method: 'POST',
            body: formData
        });

        if (response.ok) {
            const result = await response.json();
            alert('Arquivo enviado com sucesso: ' + result.FilePath);
        } else {
            alert('Falha no upload do arquivo.');
        }
    } catch (error) {
        alert('Erro: ' + error.message);
    }
}

window.onload = function()
{
    const uploadForm = document.getElementById('uploadForm');
    uploadForm.addEventListener('submit', upload);
}