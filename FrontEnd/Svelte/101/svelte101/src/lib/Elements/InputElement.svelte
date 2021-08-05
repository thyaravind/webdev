<script>
export let inputLabel;
export let placeholderText;

</script>





<label for="inputElement">{inputLabel}</label>

<input type="text" id="inputElement" name="name" required
minlength="4" maxlength="8" size="10" placeholder={placeholderText}>



<style>



#inputElement{
    background-color: var(--secondary-color);
    color: var(--primary-color);
    border: 2px solid;
    border-radius: 3px;
    width: 250px;
    height: 35px;
}

</style>