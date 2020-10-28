function RemoveExam(examId) {
    Swal.fire({
        title: '',
        text: "Sınavı silmek istiyor musun?",
        icon: 'question',
        showCancelButton: true,
        cancelButtonText: "Hayır",
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Evet'
    }).then((result) => {
        if (result.value) {
            window.location.href = '/Exam/Remove/' + examId;
        }
    })
}