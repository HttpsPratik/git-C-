
from unicodedata import category
from django.db import models
from django.utils import timezone

class Adoption(models.Model):
    email = models.EmailField(max_length=59)
    title = models.CharField(max_length=20)
    CATEGORY_CHOICES = [
        ('dog', 'Dog'),
        ('cat', 'Cat'),
        ('other', 'Other'),
    ]
    GENDER_CHOICES = [
        ('M', 'Male'),
        ('F', 'Female'),
        
    ]
    description = models.TextField()
    image = models.ImageField(upload_to='images/')
    date_added = models.DateTimeField(default=timezone.now)
    
    def __str__(self):
        return self.title