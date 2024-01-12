from django.shortcuts import render

from .models import Adoption


def index(request):
    adoption = Adoption.objects.order_by('-date_added')
    context = {'adoption': adoption}
    return render(request, 'guestbook/index.html', context)

def post(request):
    return render(request, 'guestbook/post.html')

def missing(request):
    return render(request, 'guestbook/missing.html')
