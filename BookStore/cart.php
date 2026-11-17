<?php
include("cartItem.php");
include("helpers.php");
session_start(); // after the includes: the cart in the session holds CartItem objects

?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Simple House Template</title>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:400" rel="stylesheet" />
    <link href="css/templatemo-style.css" rel="stylesheet" />
</head>
<!--

Simple House

https://templatemo.com/tm-539-simple-house

-->

<body>

    <div class="container">
        <!-- Top box -->
        <!-- Logo & Site Name -->
        <div class="placeholder">
            <div class="parallax-window" data-parallax="scroll" data-image-src="img/simple-house-01.jpg">
                <div class="tm-header">
                    <div class="row tm-header-inner">
                        <div class="col-md-6 col-12">
                            <img src="img/simple-house-logo.png" alt="Logo" class="tm-site-logo" />
                            <div class="tm-site-text-box">
                                <h1 class="tm-site-title">Simple House</h1>
                                <h6 class="tm-site-description">new restaurant template</h6>
                            </div>
                        </div>
                        <nav class="col-md-6 col-12 tm-nav">
                            <ul class="tm-nav-ul">
                                <li class="tm-nav-li"><a href="index.php" class="tm-nav-link active">Home</a></li>
                                <li class="tm-nav-li"><a href="cart.php" class="tm-nav-link">View Cart</a></li>
                                <li class="tm-nav-li"><a href="contact.html" class="tm-nav-link">Contact</a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>

        <main>
            <form action="" method="post">
                <?php
                $total = 0;
                if (isset($_SESSION["cart"])) {
                    $cart = $_SESSION["cart"];
                ?><table>
                        <tr>
                            <th>Book Id</th>
                            <th>Title</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Total</th>
                            <th>Update</th>
                        </tr>
                        <?php
                        foreach ($cart as $item) {
                            $cost = $item->Quantity * $item->Price;
                            $total = $total + $cost;
                        ?>
                            <tr>
                                <td>
                                    <?php echo h($item->Id) ?>
                                </td>
                                <td>
                                    <?php echo h($item->Title) ?>
                                </td>
                                <td>
                                    <?php echo h($item->Price) ?>
                                </td>
                                <td>
                                    <?php echo h($item->Quantity) ?>
                                </td>
                                <td>
                                    <?php echo h($cost) ?>
                                </td>
                            </tr>
                        <?php
                        }
                        ?>
                        <tr>
                            <td colspan="4">Total</td>
                            <td><?php echo h($total) ?></td>
                        </tr>
                    </table>
                <?php
                }
                ?>
            </form>
        </main>

        <footer class="tm-footer text-center">
            <p>Copyright &copy; 2020 Simple House

                | Design: <a rel="nofollow" href="https://templatemo.com">TemplateMo</a></p>
        </footer>
    </div>
    <script src="js/jquery.min.js"></script>
    <script src="js/parallax.min.js"></script>
    <script>
        $(document).ready(function() {
            // Handle click on paging links
            $('.tm-paging-link').click(function(e) {
                e.preventDefault();

                var page = $(this).text().toLowerCase();
                $('.tm-gallery-page').addClass('hidden');
                $('#tm-gallery-page-' + page).removeClass('hidden');
                $('.tm-paging-link').removeClass('active');
                $(this).addClass("active");
            });
        });
    </script>
</body>

</html>