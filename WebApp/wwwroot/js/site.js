document.querySelector("#btnLogout").addEventListener('click', confirmLogout);
function confirmLogout(event) {
    event.preventDefault();
    swal({
        title: "Importante",
        text: "Seguro que desea cerrar sesión?",
        icon: "warning",
        buttons: {
            cancel: {
                text: "Cancelar",
                value: null,
                visible: true,
                className: "",
                closeModal: true,
            },
            confirm: {
                text: "Aceptar",
                value: true,
                visible: true,
                className: "",
                closeModal: true
            }
        },
        dangerMode: true,
    }).then((willLogout) => {
        if (willLogout) {
            fetch('/Home/Logout', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                }
            })

                .then(response => {

                    window.location.href = '/';

                })
                .catch(error => console.error('Error:', error));

        } else {

        }
    });

    return false;
}