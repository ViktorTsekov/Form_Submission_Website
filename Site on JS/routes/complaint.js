const express = require('express')
const router = express.Router()
const handlebars = require('express-handlebars')
const Form = require('../models/form')
const User = require('../models/user')


router.get('/', (req,res)=>{

    res.render('complaint',{
        isadmin:    req.isadmin,
        userName: req.session.name,
        islogged : req.islogged
    });
})

router.post('/', (req,res,next)=>{
    const firstName = req.body.firstName
    const lastName = req.body.lastName
    const faculty = req.body.faculty
    const facultyNumber = req.body.facultyNumber
    const subject = req.body.subject
    const course = req.body.course
    const textField = req.body.textField

    //CREATE FORM
    let form = new Form({firstName:firstName,lastName:lastName,
        faculty:faculty,facultyNumber:facultyNumber,subject:subject,
        course:course,textField:textField});
        form.save();

    //Save form to user
        User.findById(req.session.id,(err,ans)=>{
            ans.forms.push(form);
            ans.save();
        })


res.redirect('/');

})

module.exports = router