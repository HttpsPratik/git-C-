import datetime
from random import choice
from unittest.util import _MAX_LENGTH
from django.db import models
from django.http import HttpResponse
from django.utils import timezone
from django.contrib import admin

class Question(models.Model):
    question_text = models.CharField(max_length=200)
    pub_date = models.DateTimeField("Date published")
     
    @admin.display(
        boolean=True,
        ordering="pub_date",
        description="Published recently?",
    )
    def was_published_recently(self):
        now = timezone.now()
        return now - datetime.timedelta(days=1) <= self.pub_date <= now
    def _str_(self):
        return self.question_text
    
    def was_published_recently(self):
        return self.pub_date >= timezone.now() 

class Choice(models.Model):
    question = models.ForeignKey(Question,on_delete=models.CASCADE)
    choice_text = models.CharField(max_length=200)
    votes = models.IntegerField(default=0)

    def _str_(self):
        return self.choice_text
    
def detail(request, question_id):
    return HttpResponse("The question is %s." % question_id)

def results(request, question_id):
    response = "The results of questions is %s."
    return HttpResponse(response % question_id)

def vote(request, question_id):
    return HttpResponse("You're voting on the question %s." % question_id)

