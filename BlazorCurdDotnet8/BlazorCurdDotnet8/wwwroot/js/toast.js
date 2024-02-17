function showToast() {
    var toast = document.getElementById('saveToast');
    var bootstrapToast = new bootstrap.Toast(toast);
    bootstrapToast.show();
}

window.showToast = showToast;
window.initializeToast = showToast;