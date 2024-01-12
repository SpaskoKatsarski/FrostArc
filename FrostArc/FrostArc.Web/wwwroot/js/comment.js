document.addEventListener("DOMContentLoaded", function () {
    const commentBtn = document.getElementById('comment-btn')
    const commentSection = document.getElementById('comment-section')

    commentBtn.addEventListener('click', function () {
        if (commentSection.style.display === 'none') {
            commentSection.style.display = 'block'
        } else {
            commentSection.style.display = 'none'
        }
    })
})

$(document).ready(function () {
    $('.comment-btn').click(function () {
        var buttonId = this.id;
        var lastHyphenIndex = buttonId.lastIndexOf('-');
        var postId = buttonId.substring(lastHyphenIndex + 1);
        $('#comment-section-' + postId).toggle();
    });

    $('.submit-comment').click(function () {
        var postId = $(this).data('post-id');
        var commentContent = $('#comment-field-' + postId).val();

        $.ajax({
            url: '/Post/Comment',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({ postId: postId, content: commentContent }),
            success: function (response) {
                // Success message
                alert("Comment posted successfully!");
                $('#comment-field-' + postId).val('');
                $('#comment-section-' + postId).hide();
            },
            error: function (error) {
                alert("Error occured while posting the comment.");
            }
        });
    });
});