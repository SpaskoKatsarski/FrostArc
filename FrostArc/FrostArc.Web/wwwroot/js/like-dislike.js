﻿$(document).ready(function () {
    var token = $('input[name="__RequestVerificationToken"]').val();

    $('.like-btn').click(function (e) {
        e.preventDefault();
        var postId = $(this).data('post-id');
        var userId = $(this).data('user-id')
        var button = $(this);
        $.ajax({
            url: '/Post/Like',
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
                id: postId,
                userId: userId
            },
            success: function (response) {
                button.text('👍 ' + response.likes);
            }
        });
    });

    $('.dislike-btn').click(function (e) {
        e.preventDefault();
        var postId = $(this).data('post-id');
        var userId = $(this).data('user-id')
        var button = $(this);
        $.ajax({
            url: '/Post/Dislike',
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
                id: postId,
                userId: userId
            },
            success: function (response) {
                button.text('👎 ' + response.dislikes);
            }
        });
    });
});