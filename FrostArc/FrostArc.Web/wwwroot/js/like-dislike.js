$(document).ready(function () {
    var token = $('input[name="__RequestVerificationToken"]').val();

    $('.like-btn').click(function (e) {
        e.preventDefault();
        var postId = $(this).data('post-id');
        var userId = $(this).data('user-id');
        var likeButton = $(this);
        var dislikeButton = document.querySelector('dislike-btn');
        $.ajax({
            url: '/Post/Like',
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
                id: postId,
                userId: userId
            },
            success: function (response) {
                likeButton.text('👍 ' + response.likes);
                dislikeButton.text('👎 ' + response.dislikes);
            }
        });
    });

    $('.dislike-btn').click(function (e) {
        e.preventDefault();
        var postId = $(this).data('post-id');
        var userId = $(this).data('user-id');
        var dislikeButton = $(this);
        var likeButton = document.querySelector('like-btn')
        $.ajax({
            url: '/Post/Dislike',
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
                id: postId,
                userId: userId
            },
            success: function (response) {
                dislikeButton.text('👎 ' + response.dislikes);
                likeButton.text('👍 ' + response.likes);
            }
        });
    });
});