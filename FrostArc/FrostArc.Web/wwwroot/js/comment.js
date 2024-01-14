document.addEventListener("DOMContentLoaded", function () {
    const commentBtns = document.getElementsByClassName('comment-btn');

    Array.from(commentBtns).forEach(function (btn) {
        btn.addEventListener('click', function () {
            var commentSection = this.nextElementSibling;
            if (commentSection.style.display === 'none' || commentSection.style.display === '') {
                commentSection.style.display = 'block';
            } else {
                commentSection.style.display = 'none';
            }
        });
    });
});

$(document).ready(function () {
    $('.submit-comment').click(function () {
        var postId = $(this).data('post-id');
        var userId = $(this).data('user-id');
        var commentContent = $(this).closest('.comment-section').find('.comment-field').val();

        var token = $('input[name="__RequestVerificationToken"]').val();
        var headers = { RequestVerificationToken: token };

        $.ajax({
            url: '/Post/Comment',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify({ postId: postId, userId: userId, content: commentContent }),
            headers: headers,
            success: function (response) {
                alert("Comment posted successfully!");
                var newCommentHtml = '<li><strong>' + response.newCommentUserId + ':</strong> ' + response.newComment + '</li>';
                $('#comments-' + postId).append(newCommentHtml);
                
                $('.comment-field').val('');
                $('.comment-section').hide();
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert("Error occurred: " + textStatus + ", " + errorThrown);
            }
        });
    });
});