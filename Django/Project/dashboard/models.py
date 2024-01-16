from unittest.util import _MAX_LENGTH
from django.db import models

from django.utils import timezone

class Comment(models.Model):
    email = models.EmailField(max_length=59)
    title = models.CharField(max_length=20)
    description = models.TextField()
    image = models.ImageField(upload_to='images/')
    date_added = models.DateTimeField(default=timezone.now)
    
    def __str__(self):
        return self.title