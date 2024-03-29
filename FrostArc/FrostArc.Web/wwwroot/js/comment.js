﻿document.addEventListener("DOMContentLoaded", function () {
    const commentBtns = document.getElementsByClassName('comment-btn');

    Array.from(commentBtns).forEach(function (btn) {
        btn.addEventListener('click', function () {
            var postContainer = this.closest('.post');
            var commentSection = postContainer.querySelector('.comment-section');
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
        var commentContent = $(this).closest('.post').find('.comment-field').val();

        var token = $('input[name="__RequestVerificationToken"]').val();

        var data = {
            PostId: postId,
            UserId: userId,
            Content: commentContent
        }

        $.ajax({
            url: '/Comment/Comment',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: { RequestVerificationToken: token },
            success: function (response) {
                var ownerPrefix = response.isOwner ? '🛠️ ' : '';
                var newCommentHtml = '<li style="margin-top: 16px;"><strong>' + ownerPrefix + response.newCommentUser + ':</strong> ' + response.newComment + '</li>';
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

document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.settings-toggle').forEach(item => {
        item.addEventListener('click', function (e) {
            e.preventDefault();
            
            var targetId = this.getAttribute('data-target');
            var dropdown = document.getElementById(targetId);
            
            dropdown.classList.toggle('show');
            
            e.stopPropagation();
        });
    });
    
    document.addEventListener('click', function () {
        document.querySelectorAll('.dropdown-menu').forEach(menu => {
            if (menu.classList.contains('show')) {
                menu.classList.remove('show');
            }
        });
    });
});
