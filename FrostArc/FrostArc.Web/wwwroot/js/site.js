document.getElementById('user-dropdown').addEventListener('click', showItems)

function showItems() {
    document.getElementById('dropdown-items').classList.toggle('show')
}

document.body.addEventListener('click', function (event) {
    const dropdownItems = document.getElementById('dropdown-items');
    const dropdownButton = document.getElementById('user-dropdown');

    if (!dropdownItems.contains(event.target) && event.target !== dropdownButton) {
        dropdownItems.classList.remove('show');
    }
})